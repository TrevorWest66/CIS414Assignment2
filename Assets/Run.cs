using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Run : AbstractMvoe
{
    public override float Move(float speed)
    {
        return speed * 1.5f;
    }
}
