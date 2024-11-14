using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SubRenamer.Model;

public interface ISubSyncService
{
    Task Bootstrap();
    
    Task Shutdown();
    
    event Action? OnBootstrapped;
    
    event Action? OnShutdown;
    
    bool GetIsAvailable();

    bool GetIsBootstrapped();
    
    string RetrieveExePath();
    
    string? GetExePath();
    
    Task ExecuteSubSync(IReadOnlyList<RenameTask> taskList);

    Task ExecuteSubSync(IReadOnlyList<(string video, string subtitle)> taskList);

    Task DownloadFFsubsyncBin();
}