namespace PatchProperties.Domain.Responses
{
    public class SetValuesResponse<E>
    {
        public SetValuesResponse(
            E entity,
            Dictionary<string, string> warnings)
        {
            Entity = entity;
            Warnings = warnings;
            PatchApplied = !Warnings.Any();
        }

        public SetValuesResponse(
            E entity)
        {
            Entity = entity;
            PatchApplied = !Warnings.Any();
        }

        public E Entity { get; set; }

        /// <summary>
        /// If false, evaluate "Warnings" to determine which fields were not successfully set.
        /// This would typically result from the properties on the patch model not matching those on the entity.
        /// </summary>
        public bool PatchApplied { get; set; }

        /// <summary>
        /// A list of warnings to indicte which fields were not successfully set.
        /// These warnings do affect the value of PatchApplied.
        /// </summary>
        public Dictionary<string, string> Warnings { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// A list of ingored warnings to indicte which fields were not successfully set.
        /// These warnings do not affect the value of PatchApplied.
        /// </summary>
        public Dictionary<string, string> IgnoredWarnings { get; set; } = new Dictionary<string, string>();
    }
}