namespace Lesson40_04._12._2023.Models
{
    public static class Cards
    {
        public static List<ImagesItem> ImagesItems = new List<ImagesItem>()
        {
            new ImagesItem{Id =1, Title="C#", Url="csharp.jpg"},
            new ImagesItem{Id =2, Title="JavaScript", Url="javascript.jpg"},
            new ImagesItem{Id =3, Title="HTML", Url="html.jpg"},
            new ImagesItem{Id =4, Title="Core In Action", Url="aspcore.jpg"},
            new ImagesItem{Id =5, Title="SQL", Url="sql.jpg"},
            new ImagesItem{Id =6, Title="CSS", Url="css.jpg"}
        };
    }


    public class ImagesItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

    }

}
