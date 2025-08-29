using System;
using System.Collections.Generic;
using System.Text;
using BnEGames.CipherCop.Processor.Cipher.RuneWheel;
using BnEGames.Cop.Processor.Operation;

namespace BnEGames.CipherCop.Processor.Operation
{
    public class CipherCopOperationRegistry : OperationRegistry
    {
        public CipherCopOperationRegistry() : base()
        {
            // Register Cipher Operations
            RegisterOperationType(typeof(RuneWheelCipher).FullName, typeof(RuneWheelCipher));
        }
    }
}
