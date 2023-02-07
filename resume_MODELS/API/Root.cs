using resume_MODELS.DTO;

namespace resume_MODELS.API
{
    public interface IRoot
    {
        public int selectedTemplate { get; set; }
        public Headings headings { get; set; }
        public Basics basics { get; set; }
        public List<Education> education { get; set; }
        public List<Work> work { get; set; }
        public List<Skills> skills { get; set; }
        public List<Projects> projects { get; set; }
        public List<Awards> awards { get; set; }
        public List<string> sections { get; set; }
    }
    public class Root : IRoot
    {
        public int selectedTemplate { get; set; }
        public Headings headings { get; set; }
        public Basics basics { get; set; }
        public List<Education> education { get; set; }
        public List<Work> work { get; set; }
        public List<Skills> skills { get; set; }
        public List<Projects> projects { get; set; }
        public List<Awards> awards { get; set; }
        public List<string> sections { get; set; }
        public static List<string> GetStringList(List<Section_DTO> sections)
        {
            return sections.Select(s=> s.section).ToList();
        }
        public static List<Section_DTO> GetSectionDTO(List<string> sections)
        {
            return sections.Select(s=> new Section_DTO() { section = s}).ToList();  
        }
        public static Root_DTO GetDTOFromAPI(Root root)
        {
            return new Root_DTO()
            {
                selectedTemplate = root.selectedTemplate,
                headings = Headings.GetDTOFromAPI(root.headings),
                basics = Basics.GetDTOFromAPI(root.basics),
                education = root.education.Select(e=>Education.GetDTOFromAPI(e)).ToList(),
                work = root.work.Select(w=>Work.GetDTOFromAPI(w)).ToList(),
                skills = root.skills.Select(s=> Skills.GetDTOFromAPI(s)).ToList(),
                projects = root.projects.Select(p=> Projects.GetDTOFromAPI(p)).ToList(),
                awards = root.awards.Select(a=>Awards.GetDTOFromAPI(a)).ToList(),
                sections = Root.GetSectionDTO(root.sections),
            };
        }
        public static Root GetAPIFromDTO(Root_DTO root)
        {
            return new Root()
            {
                selectedTemplate = root.selectedTemplate,
                headings = Headings.GetAPIFromDTO(root.headings),
                basics = Basics.GetAPIFromDTO(root.basics),
                education = root.education.Select(e=>Education.GetAPIFromDTO(e)).ToList(),
                work = root.work.Select(w=>Work.GetAPIFromDTO(w)).ToList(),
                skills = root.skills.Select(s=>Skills.GetAPIFromDTO(s)).ToList(),
                projects = root.projects.Select(p=>Projects.GetAPIFromDTO(p)).ToList(),
                awards = root.awards.Select(a=>Awards.GetAPIFromDTO(a)).ToList(),
                sections = Root.GetStringList(root.sections),
            };
        }

    }
}