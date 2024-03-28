namespace WyattSandersPortfolio.Models.PortfolioData
{
    public struct Testimonial {
        public string Quote;
        public string PositionAndCompany;
        public string Name;
        public bool OnLinkedIn;
    }
    public static class Testimonials
    {

        private static readonly List<Testimonial> TestimonialList = new List<Testimonial>();

        public static List<Testimonial> GetTestimonialList()
        {
            if (TestimonialList.Count == 0)
            {//add test data
                TestimonialList.Add(new Testimonial
                {
                    //max char 300
                    Quote = "\"Wyatt implemented the digital version of Singularity rapidly and effectively, not only doing the programming work, but also thoughtfully crafting the UX experience for end users. He has a strong command of gameplay implementation and broader engineering principles.\"",
                    PositionAndCompany = "Director, Octothorpe",
                    Name = "Matt Anderson",
                    OnLinkedIn = true
                });
                TestimonialList.Add(new Testimonial
                {
                    Quote = "\"Wyatt is a sharp developer with a positive attitude and a great aptitude to learn and accept feedback.\"",
                    PositionAndCompany = "CCO, Solar Forge Games",
                    Name = "Jake Muehle",
                    OnLinkedIn = true
                });
                TestimonialList.Add(new Testimonial
                {
                    Quote = "\"Wyatt is a remarkable engineer and an awesome colleague. In working together on Singularity.exe, I’ve been deeply impressed by his ability to apply critical thinking to design problems, break them down in logical ways, and then come up with innovative and creative solutions.\"",
                    PositionAndCompany = "Director, Octothorpe",
                    Name = "Matt Anderson",
                    OnLinkedIn = true
                });
                TestimonialList.Add(new Testimonial
                {
                    Quote = "\"Wyatt was always quick to jump in with helpful and relevant design feedback, and demonstrated an impressive mental library of mechanics of other games to draw on. \"",
                    PositionAndCompany = "CCO, Solar Forge Games",
                    Name = "Jake Muehle",
                    OnLinkedIn = true
                });

            }
            return TestimonialList;
        }
    }
}
