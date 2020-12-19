using Console.Contents;
using Console.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject8.Junior
{
    class S8J_StepChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            Chapter c = new Chapter("训练步骤");
            c.Contents.Add(new TextContent("1)首先根据实训项目要求，从元器件抽屉中选取PLC、按钮SB1、按钮SB2、按钮SB7、断路器QF2、断路器QF3、变频器、24V开关电源、中间继电器KA4、中间继电器KA5、三相电机等元件及设备，选取导线；", 1));
            c.Contents.Add(new TextContent("2)把选取的元器件分别安装到相应的位置，与卡轨固定。", 1));
            c.Contents.Add(new TextContent("PLC安装图如下：", 1));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\8\Junior\3.png")));
            c.Contents.Add(new TextContent("按钮安装图如下：", 1));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\8\Junior\4.png")));
            c.Contents.Add(new TextContent("断路器安装图如下：", 1));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\8\Junior\5.png")));
            c.Contents.Add(new TextContent("变频器安装图如下：", 1));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\8\Junior\6.png")));
            c.Contents.Add(new TextContent("中间继电器安装图如下：", 1));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\8\Junior\7.png")));
            c.Contents.Add(new TextContent("三相电机安装固定在机械实训模块的T型槽A3位置，安装图如下：", 1));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\8\Junior\8.png")));
            c.Contents.Add(new TextContent("3)电气元器件安装固定完毕后，对电气元件按照2.8.5.2中的第三项的电气原理图进行接线，具体接线说明如下：选择导线1一端与弱电观测面板24V+香蕉插头连接，另外一端与PLC安装板上的24V香蕉插头连接；导线2一端与弱电观测面板24V-香蕉插头连接，另外一端与PLC安装板上的0V香蕉插头连接；导线3两端分别与24V+和S/S连接；导线4两端分别与0V和按钮SB1的1+连接；导线5两端分别与按钮SB1的1-和PLC输入端X0连接；导线6两端分别与0V和按钮SB2的2+连接；导线7两端分别与按钮SB2的2-和PLC输入端X1连接；导线8两端分别与0V和按钮SB7的7+连接；导线9两端分别与按钮SB7的7-和PLC输入端X7连接；导线16两端分别与0V和PLC输出端COM0连接；导线18两端分别与PLC输出端Y0与中间继电器KA4底座端子7连接；导线19两端分别与PLC输出端Y1与中间继电器KA5底座端子7连接；导线23两端分别与24V与中间继电器KA4、KA5底座端子8连接；导线59两端分别与中间继电器KA4底座端子4与变频器M1连接；导线60两端分别与中间继电器KA5底座端子4与变频器M2连接；导线61两端分别与中间继电器KA4、KA5底座端子6与接线端子7连接；导线62两端分别与接线端子7与变频器DCM连接；导线56、57、58分别连接断路器QF2中的U、V、W与变频器的R/L1、S/L2、T/L3一一对应连接；最后把电机的三相线分别与变频器的U/T1、V/T2、W/T3连接。可参考以下图片", 1));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\8\Junior\9.png")));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\8\Junior\10.png")));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\8\Junior\11.png")));
            c.Contents.Add(new TextContent("4)对系统电路进行逐一检查（或请老师检查），确定接线准确无误，接线牢固没有虚接等问题。 ", 1));
            c.Contents.Add(new TextContent("5)对齿轮链轮机械回路进行搭建，首先把三相电机和底座安装固定在机械实训模块T型槽的A1位置，齿轮链轮分别与轴承安装紧固，最后固定在安装块上，并对各个位置进行调平，确保安装的垂直度、平行度等。支撑块分别固定在图示位置：", 1));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\8\Junior\12.png")));
            c.Contents.Add(new TextContent("6)检查完毕没有问题后，把QF0断路器与强电观察面板上的航空插头连接，顺时针转动钥匙开关给系统供电，顺时针转动强电实训板块380V开关，再闭合QF0、 QF2），并依次用万用表检测电压，顺时针转动弱电实训模块面板上的24V开关，给PLC及控制回路供电。可参考以下图片", 1));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\8\Junior\13.png")));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\8\Junior\14.png")));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\8\Junior\15.png")));
            c.Contents.Add(new PictureContent(new System.Drawing.Bitmap(@"img\8\Junior\16.png")));
            c.Contents.Add(new TextContent("7)按照训练器材中第四项的PLC梯形图对PLC进行程序编写并写入到PLC控制器中。", 1));
            c.Contents.Add(new TextContent("8)按下启动按钮SB1，观察型号1、型号2筒弹进退链轮传动系统是否正常，若不能实现要求，断开系统电源，根据运行状态判断故障原因，最终实现实训要求为止。", 1));
            c.Contents.Add(new NavigationContent(this, new S8J_InstrumentChapter(), new S8J_EvaluationChapter()));
            return c;
        }
    }
}
