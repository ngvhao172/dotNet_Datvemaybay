using Newtonsoft.Json;

namespace Csharp_DatVeMayBay.Util.CustomHelpers
{
    public static class SessionExtensions
    {
        public async static Task SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public async static Task<T> GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
