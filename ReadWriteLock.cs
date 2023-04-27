using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FinalProject
{
    /// <summary>
    /// ReadWriteLock
    /// This is the lockmanager to prevent reading and writing at the same time
    /// </summary>
    public class ReadWriteLock
    {
        private int waitingForReadLock = 0;
        private int outstandingReadLocks = 0;
        private List<Thread> waitingForWriteLock = new List<Thread>();
        private Thread writeLockThread;

        public void readLock()
        {
            lock (this)
            {
                if (writeLockThread != null)
                {
                    waitingForReadLock++;
                    while (writeLockThread != null)
                    {
                        Monitor.Wait(this);
                    }
                    waitingForReadLock--;
                }
                outstandingReadLocks++;
            }
        }

        public void writeLock()
        {
            Thread thisThread;
            lock (this)
            {
                if (writeLockThread == null && outstandingReadLocks == 0)
                {
                    writeLockThread = Thread.CurrentThread;
                    return;
                }
                thisThread = Thread.CurrentThread;
                waitingForWriteLock.Add(thisThread);
            }

            lock (thisThread)
            {
                while (thisThread != writeLockThread)
                {
                    Monitor.Wait(thisThread);
                }
            }

            lock (this)
            {
                waitingForWriteLock.Remove(thisThread);
            }
        }

        public void unlock()
        {
            lock (this)
            {
                if (outstandingReadLocks > 0)
                {
                    outstandingReadLocks--;
                    if (outstandingReadLocks == 0 && waitingForWriteLock.Count > 0)
                    {
                        writeLockThread = waitingForWriteLock[0];
                        lock (writeLockThread)
                        {
                            Monitor.PulseAll(writeLockThread);
                        }
                    }
                }
                else if (Thread.CurrentThread == writeLockThread)
                {
                    if (outstandingReadLocks == 0 && waitingForWriteLock.Count > 0)
                    {
                        writeLockThread = waitingForWriteLock[0];
                        lock (writeLockThread)
                        {
                            Monitor.PulseAll(writeLockThread);
                        }
                    }
                    else
                    {
                        writeLockThread = null;
                        if (waitingForReadLock > 0)
                        {
                            Monitor.PulseAll(this);
                        }
                    }
                }
                else
                {
                    throw new InvalidOperationException("Thread does not have lock");
                }
            }
        }
    }
}
