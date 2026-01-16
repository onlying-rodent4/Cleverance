using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleverance_2
{
    public static class Server
    {
        private static int Count;

        private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();

        public static void AddToCount(int value)
        {
            locker.EnterWriteLock();
            try
            {
                Count += value;
            }
            finally
            {
                locker.ExitWriteLock();
            }
        }

        public static int GetCount()
        {
            locker.EnterReadLock();
            try
            {
                return Count;
            }
            finally
            {
                locker.ExitReadLock();
            }
        }

    }
}
