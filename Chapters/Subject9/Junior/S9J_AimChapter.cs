using Console.Contents;
using Console.framework;

namespace Console.Chapters.Subject9.Junior
{
    class S9J_AimChapter : IChapterBuilder
    {
        public Chapter Instance { get; private set; } = new Chapter("训练目标");

        public S9J_AimChapter()
        {
            Instance.Contents.Add(new TextContent("1)能够根据实训要求选取型号1大吊臂机械缸减速传动回路相关元件进行回路的搭建；"));
            Instance.Contents.Add(new TextContent("2)能够熟练使用工具对型号1大吊臂机械缸减速传动回路相关元件进行回路的搭建；"));
            Instance.Contents.Add(new TextContent("3)能够对搭建的系统进行通电调试，确保系统能够实现实训要求；"));
            Instance.Contents.Add(new NavigationContent(this, null, new S9J_InstrumentChapter()));
        }

        public Chapter GetChapter() => Instance;
    }
}
