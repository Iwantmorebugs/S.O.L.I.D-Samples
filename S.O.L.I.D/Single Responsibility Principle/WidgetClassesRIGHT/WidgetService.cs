using Single_Responsibility_Principle.WidgetModel;

namespace Single_Responsibility_Principle.WidgetClassesRIGHT
{
    public class WidgetService
    {
        public void ChangeWidgetName(Widget widget, string newName)
        {
            widget.Name = newName;
        }
    }
}