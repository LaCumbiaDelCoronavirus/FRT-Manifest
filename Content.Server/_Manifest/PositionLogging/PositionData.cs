using Robust.Shared.Map;

namespace Content.Server.MNET.PositionLogging;

public record struct TimedPositionData(TimeSpan Time, EntityCoordinates Coordinates);
