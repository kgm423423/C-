using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example44
{
    internal class Program
    {
        public enum State
        {
            Idle, Move, Attack
        }

        static void Main(string[] args)
        {
            State gameState = State.Idle;
            Console.Write("게임의 상태를 입력하시오 (0,1,2) : ");
            gameState = (State)int.Parse(Console.ReadLine());

            switch (gameState)
            {
                case State.Idle:
                    Console.WriteLine("게임이 대기 상태 입니다.");
                    break;
                case State.Move:
                    Console.WriteLine("게임이 이동 상태 입니다.");
                    break;
                case State.Attack:
                    Console.WriteLine("게임이 공격 상태 입니다.");
                    break;
                default:
                    Console.WriteLine("잘못된 게임상태 입니다.");
                    break;
            }



            Console.ReadLine();
        }
    }
}
