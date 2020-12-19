using Console.Contents;
using Console.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject9.Senior
{
    class S9S_StepChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("训练步骤");
            this.AddText(c, "1）根据2.9.6.5故障原因分析中的故障定位流程进行辅助分析，判定故障原因。"); 
            this.AddText(c, "2）选择合适的测量点位置安装固定振动传感器、噪声传感器以及位移传感器，将传感器电源线连接至配电设备，将传感器信号线接入至数据采集卡，通过USB（或网线）将数据采集卡连接至电脑，并与配套软件实现数据互联；传感器通过香蕉插头与面板上的香蕉插座连接，具体连接参考下图：");
            this.AddPicture(c,new System.Drawing.Bitmap(@"img\9\Senior\step.png"));
            this.AddText(c, "3）操作测量分析软件对齿轮传动系统的异响、颤动水平以及齿轮轴位移变化曲线进行测量分析，查找引起链轮异响、颤动的准确位置以及原因可能为：");
            this.AddText(c, "① 齿轮缺乏润滑；");
            this.AddText(c, "② 齿轮断齿；");
            this.AddText(c, "③ 齿轮副啮合间隙过大；");
            this.AddText(c, "④ 主动齿轮轴与从动齿轮轴不平行；");
            this.AddText(c, "⑤ 齿轮存在点蚀、剥落等磨损；");
            this.AddText(c, "4）分别通过观察齿轮的润滑情况、齿轮的外观情况、通过塞尺检测齿轮副啮合间隙、通过位移传感器进行回转跳动轨迹绘制来判定齿轮轴是否平行、通过振动传感器采集数据，引入FFT变换进行诊断判断齿轮是否存在点蚀、剥落；根据观察测量情况判定导致齿轮传动异响、颤动的具体原因；");
            this.AddText(c, "5）断开系统电源，根据不同的故障原因做出具体维修措施：");
            this.AddText(c, "① 齿轮缺乏润滑导致齿轮传动异响、颤动时，对油脂润滑泵加油，启动油脂润滑泵对齿轮进行均匀润滑；");
            this.AddText(c, "② 齿轮断齿导致齿轮传动异响、颤动时，选取相同规格型号的齿轮进行更换，并对系统进行充分润滑；");
            this.AddText(c, "③ 主动齿轮与从动齿轮间隙过大导致齿轮传动异响、颤动时，使用塞尺、无反弹锤等工具对齿轮进行微调；");
            this.AddText(c, "④ 主动齿轮轴与从动齿轮轴不平行导致齿轮传动异响、颤动时，应用百分表测量主/从动齿轮轴在水平和垂直方向的距离并进行微调，使主动齿轮和从动齿轮轴平行；");
            this.AddText(c, "⑤ 齿轮点蚀、剥落导致齿轮传动异响、颤动时，选取相同规格型号的齿轮进行更换，并对系统进行充分润滑；");
            this.AddText(c, "6）对故障点维修完毕后，对系统进行装配，并逐一检查维修更换部件安装是否正确牢固； ");
            this.AddText(c, "7）启动系统运行，检验故障是否完全得到解决，如仍存在故障重复以上第2-5步，直至恢复正常工作。");

            c.Contents.Add(new NavigationContent(this, new S9S_FailModeChapter(), new S9S_EvaluationChapter()));
            return c;
        }
    }
}
