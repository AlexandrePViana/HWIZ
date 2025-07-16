using System.Reflection;
using System.Linq;

namespace HWIZ.Domain.ClassMapper
{
    public static class SimpleMapper
    {
        // Maps and returns a new instance of TTarget from a TSource
        public static TTarget Map<TSource, TTarget>(TSource source) where TTarget : new()
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            var target = new TTarget();
            MapTo(source, target);
            return target;
        }

        // Maps properties from source to an existing target instance
        public static void MapTo<TSource, TTarget>(TSource source, TTarget target)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            var sourceProperties = typeof(TSource).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var targetProperties = typeof(TTarget).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var sProp in sourceProperties)
            {
                var tProp = targetProperties.FirstOrDefault(
                    p => string.Equals(p.Name, sProp.Name, StringComparison.OrdinalIgnoreCase)
                         && p.PropertyType == sProp.PropertyType
                         && p.CanWrite);

                if (tProp != null)
                {
                    tProp.SetValue(target, sProp.GetValue(source));
                }
            }
        }
    }
}
