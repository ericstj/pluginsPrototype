using System.Text.Json;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace task;
public class MyTask : Microsoft.Build.Utilities.Task
{
    public override bool Execute()
    {
        string[] message = [ "Hello", "From", "Task" ];
        // use JsonSerializer to serialize message
        var json = JsonSerializer.Serialize(message);
        Log.LogMessage(MessageImportance.High, json);
        
        return true;
    }

}
