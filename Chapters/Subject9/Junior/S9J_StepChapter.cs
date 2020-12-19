using Console.Contents;
using Console.framework;

namespace Console.Chapters.Subject9.Junior
{
    class S9J_StepChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            Chapter c = new Chapter("训练步骤");
            c.Contents.Add(new TextContent("1)	首先根据实训项目要求，从元器件抽屉中选取PLC、旋钮开关SA2、中间继电器KA2、中间继电器KA3、行程开关SQ1、接近开关SQ2、选取导线；", 1));
            c.Contents.Add(new TextContent("2)	把选取的电气元器件分别安装到相应的位置，与卡轨固定。", 1));
            c.Contents.Add(new TextContent("PLC安装图如下：", 1));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\9\3.png")));
            c.Contents.Add(new TextContent("按钮安装图如下：", 1));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\9\4.png")));
            c.Contents.Add(new TextContent("中间继电器安装图如下：", 1));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\9\5.png")));
            c.Contents.Add(new TextContent("3)	电气元器件安装固定完毕后，对电气元件按照2.9.5.2中的第三项的电气原理图进行接线，具体接线说明如下：选择导线1一端与弱电观测面板24V+香蕉插头连接，另外一端与PLC安装板上的24V香蕉插头连接；导线2一端与弱电观测面板24V-香蕉插头连接，另外一端与PLC安装板上的0V香蕉插头连接；导线3两端分别与24V+和S/S连接；导线12两端分别与0V和旋钮开关SA2的11+连接；导线13两端分别与旋钮开关SA2的11-和PLC输入端X12连接；导线14两端分别与0V和旋钮开关SA2的12+连接；导线15两端分别与旋钮开关SA2的12-和PLC输入端X13连接；导线17两端分别与0V和PLC输出端COM2连接；导线21两端分别与PLC输出端Y12与中间继电器KA2底座端子7连接；导线22两端分别与PLC输出端Y13与中间继电器KA3底座端子7连接；导线23两端分别与24V与中间继电器KA2、KA3底座端子8连接；导线24两端分别与24V与中间继电器KA2、KA3底座端子4连接；导线28两端分别与中间继电器KA2底座端子6与接线端子5连接；导线29两端分别与中间继电器KA3底座端子6与接线端子6连接；行程开关SQ1红色香蕉插头与PLC中的X2连接，蓝色香蕉插头与0V连接；接近开关SQ2红色香蕉插头与PLC中的X3连接，蓝色香蕉插头与0V连接；可参考以下图片", 1));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\9\6.png")));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\9\7.png")));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\9\8.png")));
            c.Contents.Add(new TextContent("4)	接线完成后对系统电路进行逐一检查，确定接线准确牢固；", 1));
            c.Contents.Add(new TextContent("5)	对液压马达进行液压回路的搭建。从元器件抽屉选取液压马达安装固定到机械实训模块T型槽的H1位置，机械缸安装固定在液压实训模块T型槽D4位置，支撑块及相关的轴承安装位置可参考附图，液压软管1两端分别连接液压测试面板上的测压接头1和电磁换向阀的P口，液压软管2两端分别连接液压测试面板上的测压接头2和电磁换向阀的T口，液压软管3两端分别连接电磁换向阀的A口和液压马达的A口，液压软管4两端分别连接电磁换向阀的B口和液压马达的B口。可参考以下图片", 1));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\9\9.png")));
            c.Contents.Add(new TextContent("6)	把电磁换向阀接入到电气控制回路中，电磁换向阀线圈1中的红色导线与接线端子5连接，蓝色导线与接线端子2连接；电磁换向阀线圈2中的红色导线与接线端子6连接，蓝色导线与接线端子3连接；", 1));
            c.Contents.Add(new TextContent("7)	安装完成之后对整个回路进行检查，检查完毕没有问题后，顺时针转动钥匙开关给系统供电，顺时针转动弱电实训模块面板上的24V开关，给PLC及控制回路供电；", 1));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\9\10.png")));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\9\11.png")));
            c.Contents.Add(new TextContent("8)	按照PLC梯形图对PLC进行程序编写并写入到PLC控制器中；", 1));
            c.Contents.Add(new TextContent("9)	最后对系统进行通电调试，顺时针转动泵站启、停旋钮开关，启动泵站，逆时针或者顺时针转动旋钮开关SA2观察型号1大吊臂机械缸减速传动回路动作是否正常；", 1));
            c.Contents.Add(new TextContent("10)	若不能实现要求，断开系统电源，根据运行状态判断故障原因对主回路以及控制回路进行重新调试，最终实现实训要求为止", 1));
            c.Contents.Add(new NavigationContent(this, new S9J_InstrumentChapter(), new S9J_EvaluationChapter()));
            return c;
        }
    }
}
