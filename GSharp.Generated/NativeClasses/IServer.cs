//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSharp.Generated.NativeClasses {
    using System.ComponentModel;
    using System;
    
    
    public interface IServer {
        
        void dtorIServer();
        
        int GetNumClients();
        
        int GetNumProxies();
        
        int GetNumFakeClients();
        
        int GetMaxClients();
        
        /// <param name='index'></param>
        System.IntPtr GetClient(int index);
        
        int GetClientCount();
        
        int GetUDPPort();
        
        float GetTime();
        
        int GetTick();
        
        float GetTickInterval();
        
        string GetName();
        
        string GetMapName();
        
        int GetSpawnCount();
        
        int GetNumClasses();
        
        int GetClassBits();
        
        /// <param name='avgIn'></param>
        /// <param name='avgOut'></param>
        void GetNetStats(System.IntPtr avgIn, System.IntPtr avgOut);
        
        int GetNumPlayers();
        
        /// <param name='nClientIndex'></param>
        /// <param name='pinfo'></param>
        bool GetPlayerInfo(int nClientIndex, System.IntPtr pinfo);
        
        bool IsActive();
        
        bool IsLoading();
        
        bool IsDedicated();
        
        bool IsPaused();
        
        bool IsMultiplayer();
        
        bool IsPausable();
        
        bool IsHLTV();
        
        bool IsReplay();
        
        string GetPassword();
        
        /// <param name='paused'></param>
        void SetPaused(bool paused);
        
        /// <param name='password'></param>
        void SetPassword(string password);
        
        /// <param name='msg'></param>
        /// <param name='onlyActive'></param>
        /// <param name='reliable'></param>
        void BroadcastMessage(System.IntPtr msg, bool onlyActive, bool reliable);
        
        /// <param name='msg'></param>
        /// <param name='filter'></param>
        void BroadcastMessage(System.IntPtr msg, System.IntPtr filter);
        
        /// <param name='client'></param>
        /// <param name='reason'></param>
        void DisconnectClient(System.IntPtr client, string reason);
    }
}
