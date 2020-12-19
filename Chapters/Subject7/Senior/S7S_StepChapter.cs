using Console.Contents;
using Console.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject8.Senoir
{
    class S7S_StepChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("训练步骤");
            this.AddText(c, "1)根据中级故障原因分析中的故障定位流程进行辅助分析，判定故障原因。");
            this.AddText(c, "2)使用振动测量仪、噪声传感器、温度传感器对链轮传动系统噪声、振动数据、进行采集，利用软件系统对采集的数据进行读取，传感器采集的数据经过二次仪表处理后上传到上位机软件；传感器通过香蕉插头与面板上的香蕉插座连接，具体连接参考下图：");
            this.AddPicture(c, new System.Drawing.Bitmap(@"img\8\Senior\1.png"));
            this.AddText(c, "3)操作测量分析软件对链轮传动系统的振动、噪声水平进行测量分析，并准确查找引起振动、噪声过大的原因可能为：");
            this.AddText(c, "① 链轮传动轴间距过大或过小；");
            this.AddText(c, "② 链轮或链条磨损；");
            this.AddText(c, "③ 链轮不共面；");
            this.AddText(c, "④ 链轮主、从轴不平行；");
            this.AddText(c, "4)使用钢板尺或卡尺测量链轮传动轴的间距，确定传动间距是否过大或过小；使用卡尺测量链轮齿或链条的数值与标准值对比，根据测量数值情况判定齿轮/链条磨损情况；使用卡尺测量主、从链轮与T型安装槽基准位置的距离，判定链轮是否共面，调整其中一个齿轮的位置使主从齿轮共面；应用百分表分测量主动齿轮轴轴承座附近的母线高度，计算高度差，调整一组轴承座高度差，使其高度方向平行于安装面；同样在T型安装台选取一个基准位置，使齿轮轴在水平方向同样保持平行，从动齿轮同样操作；");
            this.AddText(c, "5)断开系统电源，根据不同的故障原因做出具体维修措施：");
            this.AddText(c, "① 链轮传动轴间距过大或过小导致链轮传动噪声、振动过大时，使用工具对链轮传动轴间距进行微调，使传动间距合适；链轮间距过大链条过松时，加装张紧装置，通过调整张紧装置调节链条的松紧度；");
            this.AddText(c, "② 链轮或链条磨损导致链轮传动噪声、振动过大时，使用工具对磨损的链轮/链条进行更换；");
            this.AddText(c, "③ 链轮不共面导致链轮传动噪声、振动过大时，使用工具对链轮进行微调，使链轮共面；");
            this.AddText(c, "④ 链轮前后轴不平行导致链轮传动噪声、振动过大时，使用工具对链轮轴进行调整使主从齿轮轴平行");
            this.AddText(c, "6)对故障点维修完毕后，对系统进行装配，并逐一检查维修更换部件安装是否正确牢固；");
            this.AddText(c, "7)启动系统运行，检验故障是否完全得到解决，如仍存在故障重复以上第2-5步，直至恢复正常工作。");

            c.Contents.Add(new NavigationContent(this, new S7S_FailModeChapter(), new S7S_EvaluationChapter()));
            return c;
        }
    }
}
