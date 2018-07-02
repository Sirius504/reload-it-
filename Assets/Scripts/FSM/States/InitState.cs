using ReloadIt;

public class InitState : FSMState<ReloadIt.Game> {

    static readonly InitState instance = new InitState();
    public static InitState Instance
    {
        get
        {
            return instance;
        }
    }

    public override void Enter(Game entity)
    {
        //throw new System.NotImplementedException();
    }

    public override void Execute(Game entity)
    {
        throw new System.NotImplementedException();
    }

    public override void Exit(Game entity)
    {
        throw new System.NotImplementedException();
    }
}
