﻿using Google.Protobuf;

namespace AElf.Kernel
{
    public interface ITransaction : IHashProvider
    {
        /// <summary>
        /// Method name
        /// </summary>
        string MethodName { get; set; }

        /// <summary>
        /// Params
        /// </summary>
        ByteString Params { get; set; }

        /// <summary>
        /// The caller铯tting
        /// </summary>
        Hash From { get; set; }

        /// <summary>
        /// The instrance of a smart contract
        /// </summary>
        Hash To { get; set; }

        ulong IncrementId { get; set; }
        
        ITransactionParallelMetaData GetParallelMetaData();
    }

}