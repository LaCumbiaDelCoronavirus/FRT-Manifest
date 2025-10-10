
using Robust.Shared.Collections;
using Robust.Shared.Timing;

namespace Content.Server.MNET.PositionLogging;

/// <summary>
///     Logs position of an entity every tick. Meant for short-term storage.
/// </summary>
// TODO: Move 2 shared maybe.
[RegisterComponent]
public sealed partial class PositionLoggingComponent : Component
{
    public OverflowDictionary<GameTick, TimedPositionData> Logs = new(PositionLoggingSystem.MaximumLogLength);
}
