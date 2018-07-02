using ReloadIt;
using UnityEngine;
using UnityEngine.AI;

public class MeleeEnemy : PoolableBehavior, IShotable, IPlayerInteractable
{
    private Transform target;
    private NavMeshAgent agent;

    public void OnBeingShot(Bullet bullet)
    {
        PutToPool();
    }

    public void OnPlayerCollided(Player player)
    {
        App.Game.fsm.ChangeState(GameOverState.Instance);
    }

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = App.Game.Player.transform;
    }

    public void Update()
    {
        agent.SetDestination(target.position);        
    }
}
