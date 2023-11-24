namespace Hackathon.HackstreetBoys.WinForms.CrashLogs;

public sealed record CrashLogsData(string Timestamp, string Category, string Error, string FullError)
{
    public static readonly CrashLogsData[] DemoData = new[]
    {
        new CrashLogsData("2022-12-27 14:43:00Z", "Fatal Error",
            "Process exited due to unexpected condition.", """
                System.Reflection.TargetInvocationException: Exception has been thrown by the target of an invocation.
                ---> Eurofins.Digital.Workers.TriggerException: Unable to resolve type Eurofins.NotificationCenter.Notifications.Service.Workers.NotificationActivities.Models.EventNotification, Eurofins.NotificationCenter.Notifications.Service.Workers.NotificationActivities.
                  at Eurofins.Digital.Workers.Triggers.Messaging.MessageTrigger.set_Value(String value)
                  --- End of inner exception stack trace ---
                  at System.RuntimeMethodHandle.InvokeMethod(Object target, Span`1& arguments, Signature sig, Boolean constructor, Boolean wrapExceptions)
                  at System.Reflection.RuntimeMethodInfo.InvokeOneParameter(Object obj, BindingFlags invokeAttr, Binder binder, Object parameter, CultureInfo culture)
                  at System.Reflection.RuntimePropertyInfo.SetValue(Object obj, Object value, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture)
                  at System.Reflection.PropertyInfo.SetValue(Object obj, Object value)
                  at Eurofins.Digital.Utilities.ReflectionExtensions.TryAssignPropertyFromString[T](T instance, PropertyInfo property, String str)
                  at Eurofins.Digital.Workers.JobDetails.JobsFactory.CreateTrigger(Type triggerType, TriggerConfig triggerConfig)
                  at Eurofins.Digital.Workers.JobDetails.JobsFactory.GetJobs()+MoveNext()
                  at System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
                  at Eurofins.Digital.Workers.ServiceCollectionExtensions.AddWorkers(IServiceCollection services, IConfiguration configuration, Action`2 builderAction)
                  at Eurofins.Digital.Workers.HostBuilderExtensions.<>c__DisplayClass0_0.<UseBackgroundWorkers>b__0(HostBuilderContext ctx, IServiceCollection services)
                  at Microsoft.Extensions.Hosting.HostBuilder.CreateServiceProvider()
                  at Microsoft.Extensions.Hosting.HostBuilder.Build()
                  at Eurofins.Digital.Hosting.DopHost.RunAsync(String[] args, Action`1 builderSetup, CancellationToken cancellationToken)
                """),

        new CrashLogsData("2022-12-27 14:49:36Z", "Fatal Error",
            "Process exited due to unexpected condition.", """
                System.Reflection.TargetInvocationException: Exception has been thrown by the target of an invocation.
                ---> Eurofins.Digital.Workers.TriggerException: Unable to resolve type Eurofins.NotificationCenter.RulesEngine.Contract.Models.EventNotificationModels.EventNotification, Eurofins.NotificationCenter.RulesEngine.Contract.
                  at Eurofins.Digital.Workers.Triggers.Messaging.MessageTrigger.set_Value(String value)
                  --- End of inner exception stack trace ---
                  at System.RuntimeMethodHandle.InvokeMethod(Object target, Span`1& arguments, Signature sig, Boolean constructor, Boolean wrapExceptions)
                  at System.Reflection.RuntimeMethodInfo.InvokeOneParameter(Object obj, BindingFlags invokeAttr, Binder binder, Object parameter, CultureInfo culture)
                  at System.Reflection.RuntimePropertyInfo.SetValue(Object obj, Object value, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture)
                  at System.Reflection.PropertyInfo.SetValue(Object obj, Object value)
                  at Eurofins.Digital.Utilities.ReflectionExtensions.TryAssignPropertyFromString[T](T instance, PropertyInfo property, String str)
                  at Eurofins.Digital.Workers.JobDetails.JobsFactory.CreateTrigger(Type triggerType, TriggerConfig triggerConfig)
                  at Eurofins.Digital.Workers.JobDetails.JobsFactory.GetJobs()+MoveNext()
                  at System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
                  at Eurofins.Digital.Workers.ServiceCollectionExtensions.AddWorkers(IServiceCollection services, IConfiguration configuration, Action`2 builderAction)
                  at Eurofins.Digital.Workers.HostBuilderExtensions.<>c__DisplayClass0_0.<UseBackgroundWorkers>b__0(HostBuilderContext ctx, IServiceCollection services)
                  at Microsoft.Extensions.Hosting.HostBuilder.CreateServiceProvider()
                  at Microsoft.Extensions.Hosting.HostBuilder.Build()
                  at Eurofins.Digital.Hosting.DopHost.RunAsync(String[] args, Action`1 builderSetup, CancellationToken cancellationToken)
                """),

        new CrashLogsData("2022-12-27 14:51:21Z", "Logger Error",
            "Unable to find a method called Seq. Candidate methods are:", """
                Serilog.LoggerConfiguration Conditional(Serilog.Configuration.LoggerSinkConfiguration, System.String, System.Action`1[Serilog.Configuration.LoggerSinkConfiguration])
                Serilog.LoggerConfiguration Providers(Serilog.Configuration.LoggerSinkConfiguration, Serilog.Extensions.Logging.LoggerProviderCollection, Serilog.Events.LogEventLevel, Serilog.Core.LoggingLevelSwitch)
                Serilog.LoggerConfiguration Console(Serilog.Configuration.LoggerSinkConfiguration, Serilog.Events.LogEventLevel, System.String, System.IFormatProvider, Serilog.Core.LoggingLevelSwitch, System.Nullable`1[Serilog.Events.LogEventLevel], Serilog.Sinks.SystemConsole.Themes.ConsoleTheme, Boolean, System.Object)
                Serilog.LoggerConfiguration Console(Serilog.Configuration.LoggerSinkConfiguration, Serilog.Formatting.ITextFormatter, Serilog.Events.LogEventLevel, Serilog.Core.LoggingLevelSwitch, System.Nullable`1[Serilog.Events.LogEventLevel], System.Object)
                Serilog.LoggerConfiguration Debug(Serilog.Configuration.LoggerSinkConfiguration, Serilog.Events.LogEventLevel, System.String, System.IFormatProvider, Serilog.Core.LoggingLevelSwitch)
                Serilog.LoggerConfiguration Debug(Serilog.Configuration.LoggerSinkConfiguration, Serilog.Formatting.ITextFormatter, Serilog.Events.LogEventLevel, Serilog.Core.LoggingLevelSwitch)
                Serilog.LoggerConfiguration File(Serilog.Configuration.LoggerSinkConfiguration, System.String, Serilog.Events.LogEventLevel, System.String, System.IFormatProvider, System.Nullable`1[System.Int64], Serilog.Core.LoggingLevelSwitch, Boolean, Boolean, System.Nullable`1[System.TimeSpan])
                Serilog.LoggerConfiguration File(Serilog.Configuration.LoggerSinkConfiguration, Serilog.Formatting.ITextFormatter, System.String, Serilog.Events.LogEventLevel, System.Nullable`1[System.Int64], Serilog.Core.LoggingLevelSwitch, Boolean, Boolean, System.Nullable`1[System.TimeSpan])
                Serilog.LoggerConfiguration File(Serilog.Configuration.LoggerSinkConfiguration, System.String, Serilog.Events.LogEventLevel, System.String, System.IFormatProvider, System.Nullable`1[System.Int64], Serilog.Core.LoggingLevelSwitch, Boolean, Boolean, System.Nullable`1[System.TimeSpan], Serilog.RollingInterval, Boolean, System.Nullable`1[System.Int32], System.Text.Encoding)
                Serilog.LoggerConfiguration File(Serilog.Configuration.LoggerSinkConfiguration, Serilog.Formatting.ITextFormatter, System.String, Serilog.Events.LogEventLevel, System.Nullable`1[System.Int64], Serilog.Core.LoggingLevelSwitch, Boolean, Boolean, System.Nullable`1[System.TimeSpan], Serilog.RollingInterval, Boolean, System.Nullable`1[System.Int32], System.Text.Encoding)
                Serilog.LoggerConfiguration File(Serilog.Configuration.LoggerSinkConfiguration, System.String, Serilog.Events.LogEventLevel, System.String, System.IFormatProvider, System.Nullable`1[System.Int64], Serilog.Core.LoggingLevelSwitch, Boolean, Boolean, System.Nullable`1[System.TimeSpan], Serilog.RollingInterval, Boolean, System.Nullable`1[System.Int32], System.Text.Encoding, Serilog.Sinks.File.FileLifecycleHooks, System.Nullable`1[System.TimeSpan])
                Serilog.LoggerConfiguration File(Serilog.Configuration.LoggerSinkConfiguration, Serilog.Formatting.ITextFormatter, System.String, Serilog.Events.LogEventLevel, System.Nullable`1[System.Int64], Serilog.Core.LoggingLevelSwitch, Boolean, Boolean, System.Nullable`1[System.TimeSpan], Serilog.RollingInterval, Boolean, System.Nullable`1[System.Int32], System.Text.Encoding, Serilog.Sinks.File.FileLifecycleHooks, System.Nullable`1[System.TimeSpan])
                Serilog.LoggerConfiguration Sink(Serilog.Configuration.LoggerSinkConfiguration, Serilog.Core.ILogEventSink, Serilog.Events.LogEventLevel, Serilog.Core.LoggingLevelSwitch)
                Serilog.LoggerConfiguration Logger(Serilog.Configuration.LoggerSinkConfiguration, System.Action`1[Serilog.LoggerConfiguration], Serilog.Events.LogEventLevel, Serilog.Core.LoggingLevelSwitch)
                """),

        new CrashLogsData("2022-12-27 14:51:24Z", "Fatal Error",
            "Process exited due to unexpected condition.", """
                System.ArgumentException: An item with the same key has already been added. Key: eesb
                at System.Collections.Generic.Dictionary`2.TryInsert(TKey key, TValue value, InsertionBehavior behavior)
                at System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value)
                at Eurofins.Digital.Messaging.Providers.Eesb.Configuration.EesbSettingsTransposer.TransposeGlobals(MessagingSettings config, IConfiguration configuration) in D:\Agent_VD403\_work\34\s\providers\Eesb\Configuration\EesbSettingsTransposer.cs:line 27
                at Eurofins.Digital.Messaging.DopExtentionEesbSettingTransposer.TransposeGlobals(MessagingSettings config, IConfiguration configuration) in D:\Agent_VD403\_work\34\s\extension\Eesb\DopExtentionEesbSettingTransposer.cs:line 30
                at Eurofins.Digital.Messaging.Endpoint.Configuration.ConfigurationTransformer.Configure(MessagingSettings options) in D:\Agent_VD403\_work\34\s\src\Messaging.Endpoint\Configuration\ConfigurationTransformer.cs:line 39
                at Microsoft.Extensions.Options.OptionsFactory`1.Create(String name)
                at Microsoft.Extensions.Options.UnnamedOptionsManager`1.get_Value()
                at Eurofins.Digital.Messaging.Endpoint.Configuration.DefaultConfigurationInterpreter.ReadConfiguration()
                at Eurofins.Digital.Messaging.Endpoint.MessagingCoordinator.WireUp() in D:\Agent_VD403\_work\34\s\src\Messaging.Endpoint\MessagingCoordinator.cs:line 181
                at Eurofins.Digital.Messaging.Endpoint.MessagingCoordinator.StartAsync(CancellationToken cancellationToken) in D:\Agent_VD403\_work\34\s\src\Messaging.Endpoint\MessagingCoordinator.cs:line 58
                at Microsoft.Extensions.Hosting.Internal.Host.StartAsync(CancellationToken cancellationToken)
                at Microsoft.Extensions.Hosting.HostingAbstractionsHostExtensions.RunAsync(IHost host, CancellationToken token)
                at Microsoft.Extensions.Hosting.HostingAbstractionsHostExtensions.RunAsync(IHost host, CancellationToken token)
                at Eurofins.Digital.Hosting.DopHost.RunAsync(String[] args, Action`1 builderSetup, CancellationToken cancellationToken)
                """),
    };
}
