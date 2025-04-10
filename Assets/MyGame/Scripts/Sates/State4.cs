// Represents 4 digit for a 7 segment display
public class State4 : ISevenSegmentDisplayState
{
    static ISevenSegmentDisplayState _state;
    public int GetDigit() {
        return 4;
    }

    public ISevenSegmentDisplayState CountUp() {
        return State5.GetState();
    }

    public ISevenSegmentDisplayState CountDown() {
        return State3.GetState();
    }
    private State4() {
    }
    public static ISevenSegmentDisplayState GetState() {
        if (_state == null) {
            _state = new State4();
        }
        return _state;
    }

}
