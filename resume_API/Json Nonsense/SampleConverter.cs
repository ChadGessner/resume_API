using Newtonsoft.Json.Converters;
using resume_MODELS.API;

namespace resume_API.Json_Nonsense
{
    public class RootConverter : CustomCreationConverter<Root>
    {
        public override Root Create(Type objectType)
        {
            return new Root();
        }
    }
}
