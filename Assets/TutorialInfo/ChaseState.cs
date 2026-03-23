using UnityEditor.Search;
using UnityEngine;
using UnityEngine.AI;
namespace GlosCol
{
        public class ChaseState : State
    {
        public ChaseState(EnemyAI enemy) : base(enemy) { }

        public override void Enter()
        {
            enemy.agent.isStopped = false;
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created

        public override void Update()
        {
            enemy.agent.SetDestination(enemy.player.position);
            float distance = enemy.DistanceToPlayer();

            if (distance <= enemy.attackRange)
            {
                enemy.ChangeState(new PatrolState(enemy));
                return;
            }
            if (distance > enemy.sightRange)
            {
                enemy.ChangeState(new SearchState(enemy));
            }
        }
    }
}