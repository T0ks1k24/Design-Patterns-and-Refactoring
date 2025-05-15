using Lab4_2.@class;
using Lab4_2.Interface;

namespace Lab4_2;

public class BirdAdapter : Bird
{
    private readonly IAirplane _airplane;

    public BirdAdapter(IAirplane airplane)
    {
        _airplane = airplane;
    }

    public override string Fly()
    {
        return _airplane.TakeOff(); 
    }
}
