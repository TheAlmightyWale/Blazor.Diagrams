using Blazor.Diagrams.Core.Geometry;

namespace Blazor.Diagrams.Core.Models.Base
{
    // I'm assuming that all movable models (nodes & groups for now) are also selectable,
    // I believe it makes sense since if you click to move something then you're also selecting
    public abstract class MovableModel : SelectableModel
    {
        protected MovableModel(Point? position = null)
        {
            Position = position ?? Point.Zero;
        }

		protected MovableModel(string id, Point? position = null) : base(id)
        {
            Position = position ?? Point.Zero;
        }

        public Point Position { get; set; }

        public virtual void SetPosition(double x, double y) => Position = new Point(x, y);
        public virtual void EndMovement() { /*Do nothing*/ }
    }
}
