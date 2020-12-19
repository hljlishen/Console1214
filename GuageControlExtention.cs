using System.Linq;
using System.Threading.Tasks;

namespace DevComponents.Instrumentation
{
    public static class GuageControlExtention
    {
        public static void SetGaugeValue(this GaugeControl c, double value)
        {
            double factor = 1;
            if (!string.IsNullOrEmpty(c.Tag as string))
                factor = double.Parse(c.Tag as string);
            Task.Run(() => GetFirstPoint(c).Value = value / factor);
        }

        private static GaugePointer GetFirstPoint(GaugeControl c)
        {
            if (c.CircularScales.Count > 0)
                return c.CircularScales.First().Pointers.First();
            else
                return c.LinearScales.First().Pointers.First();
        }
        public static void InitializeGauge(this GaugeControl c, bool bigIndicator = false)
        {
            var stateIndicator = GetGuageItem<StateIndicator>(c);
            if (stateIndicator != null)
            {
                c.SectionEnter += C_SectionEnter;
            }

            var digital = GetGuageItem<NumericIndicator>(c);
            if (digital != null)
            {
                c.PointerValueChanged += C_PointerValueChanged;
                if (bigIndicator)
                {
                    digital.Size = new System.Drawing.SizeF(0.5f, 0.22f);
                }
            }
        }

        private static void C_SectionEnter(object sender, SectionEnterEventArgs e)
        {
            string sectionName = e.Section.Name.ToLower();
            if (sectionName != "normal" && sectionName != "warning" && sectionName != "alarm")
                return;
            var stateIndicator = GetGuageItem<StateIndicator>(sender as GaugeControl);
            stateIndicator.BackColor.Color1 = e.Section.MajorTickMarkFillColor.Color1;
            stateIndicator.BackColor.Color2 = e.Section.MajorTickMarkFillColor.Color1;
        }

        private static void C_PointerValueChanged(object sender, PointerChangedEventArgs e)
        {
            GaugeControl c = sender as GaugeControl;
            double factor = 1;
            if (c.Tag != null && !string.IsNullOrEmpty(c.Tag as string))
                factor = double.Parse(c.Tag as string);
            var digital = GetGuageItem<NumericIndicator>(c);
            digital.Value = e.NewValue * factor;
        }

        private static T GetGuageItem<T>(GaugeControl c) where T : GaugeItem
        {
            foreach (var i in c.GaugeItems)
            {
                if (i is T)
                    return i as T;
            }
            return null;
        }
    }
}
