using System.Collections.Generic;
using System.Linq;
using Single_Responsibility_Principle.WidgetModel;

namespace Single_Responsibility_Principle.WidgetClassesRIGHT
{
    public class WidgetRepositoryRight

    {
        private readonly ICollection<Widget> _widgets;

        public void AddWidget(Widget widget)
        {
            _widgets.Add(widget);
        }

        public Widget GetWidgetByName(string name)
        {
            return _widgets.FirstOrDefault(x => x.Name == name);
        }

        public void RemoveWidget(Widget widget)
        {
            _widgets.Remove(widget);
        }
    }
}