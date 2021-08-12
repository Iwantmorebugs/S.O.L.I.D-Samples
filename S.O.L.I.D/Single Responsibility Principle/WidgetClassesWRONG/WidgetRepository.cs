using System.Collections.Generic;
using System.Linq;
using Single_Responsibility_Principle.WidgetModel;

namespace Single_Responsibility_Principle.WidgetClassesWRONG
{
    public class WidgetRepositoryWRONG
    {
        private readonly ICollection<Widget> _widgets;

        public void AddWidget(Widget widget)
        {
            _widgets.Add(widget);
        }

        //Should not be part of WidgetRepository
        public void ChangeWidgetName(Widget widget, string newName)
        {
            widget.Name = newName;
        }

        //Should not be part of WidgetRepository
        public Widget CreateWidget(string name)
        {
            return new() {Name = name};
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