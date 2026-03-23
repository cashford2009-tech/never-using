using UnityEngine;
using UnityEngine.AI;
namespace GlosCol
{

    public abstract class State
    {
        protected EnemyAI enemy;
        public State(EnemyAI enemy)
        {
            this.enemy = enemy;
        }
        public virtual void Enter() { }
        public virtual void Update() { }
        public virtual void Exit() { }

    }// Start is called once before the first execution of Update after the MonoBehaviour is created
}