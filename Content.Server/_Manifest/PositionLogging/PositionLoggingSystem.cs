using Robust.Shared.Configuration;

namespace Content.Server.MNET.PositionLogging;

/// <summary>
///     It returns.
/// </summary>
// TODO add shared support.
public sealed class PositionLoggingSystem : EntitySystem
{
    [Dependency] private readonly IConfigurationManager _configurationManager = default!;

    /// <summary>
    ///     Number of position logs a <see cref="PositionLoggingComponent"/> can contain at once. 
    /// </summary>
    public const int MaximumLogLength = 30;

    // TODO make this work on either timespans or subticks; for either: get the desired time period, and the log closest to it, and use that.
}
