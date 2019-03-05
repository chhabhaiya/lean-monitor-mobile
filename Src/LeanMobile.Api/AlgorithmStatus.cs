﻿namespace LeanMobile.Api
{
    public enum AlgorithmStatus
    {
        DeployError, 
        InQueue,    
        Running,    
        Stopped,    
        Liquidated, 
        Deleted,    
        Completed,  
        RuntimeError,
        Invalid,
        LoggingIn,
        Initializing,
        History
    }
}