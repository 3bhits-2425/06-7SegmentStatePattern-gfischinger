// Represents 5 digit for a 7 segment display
public class State5 : ISevenSegmentDisplayState
{
    static ISevenSegmentDisplayState _state;
    public int GetDigit() {
        return 5;
    }

    public ISevenSegmentDisplayState CountUp() {
        return State6.GetState();
    }

    public ISevenSegmentDisplayState CountDown() {
        return State4.GetState();
    }
    private State5() {
    }
    public static ISevenSegmentDisplayState GetState() {
        if (_state == null) {
            _state = new State5();
        }
        return _state;
    }

}
