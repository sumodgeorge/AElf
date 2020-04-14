using AElf.Kernel.SmartContract;
using AElf.Types;
using Volo.Abp.DependencyInjection;

namespace AElf.Kernel.Consensus
{
    public class ConsensusSmartContractAddressNameProvider : ISmartContractAddressNameProvider, ISingletonDependency
    {
        public static Hash Name = Hash.ComputeFrom("AElf.ContractNames.Consensus");

        public Hash ContractName => Name;
    }
}