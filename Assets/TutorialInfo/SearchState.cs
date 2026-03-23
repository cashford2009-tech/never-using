using UnityEngine;
using UnityEngine.AI;
namespace GlosCol
{


    public class SearchState : State
    {
        private float searchTime = 3f;
        private float timer;

        public SearchState(EnemyAI enemy) : base(enemy) { }

        public override void Enter()
        {
            timer = 0f;
        }

        public override void Update()
        {
            timer += Time.deltaTime;

            if (enemy.DistanceToPlayer() <= enemy.sightRange)
            {
                enemy.ChangeState(new ChaseState(enemy));
                return;
            }
            if (timer >= searchTime)
            {
                enemy.ChangeState(new PatrolState(enemy));
            }
        }

    }
}