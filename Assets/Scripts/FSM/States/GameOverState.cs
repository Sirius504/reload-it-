using ReloadIt;

public class GameOverState : FSMState<Game> {

    static readonly GameOverState instance = new GameOverState();
    public static GameOverState Instance
    {
        get
        {
            return instance;
        }
    }

    public override void Enter(Game entity)
    {
        App.Game.IngameGui.Show();
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
