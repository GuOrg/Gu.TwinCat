namespace Gu.TwinCat
{
    /// <summary>
    /// What triggers the last update of <see cref="Subscription{TPlc,TCsharp}.Value"/>.
    /// </summary>
    public enum UpdateTrigger
    {
        /// <summary>
        /// The value is not updated yet.
        /// </summary>
        None,

        /// <summary>
        /// The IAdsConnection.AdsNotificationEx event triggered the last update.
        /// </summary>
        AdsNotificationEx,

        /// <summary>
        /// The IAdsConnection.ConnectionStateChanged event triggered the last update.
        /// </summary>
        ConnectionStateChanged,

        /// <summary>
        /// A manual refresh triggered the update.
        /// </summary>
        Refresh,
    }
}
