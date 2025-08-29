using BnEGames.CipherCop.Processor.Operation;
using BnEGames.Cop.Processor;

namespace BnEGames.CipherCop.Processor
{
    public class CipherCopProcessor : CopProcessor
    {
        public CipherCopProcessor() : base(new CipherCopOperationRegistry())
        {
        }
    }
}
