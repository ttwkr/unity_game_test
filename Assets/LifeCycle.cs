using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class LifeCycle : MonoBehaviour
    {
        private void Awake()
        {
            //게임 오브젝트 처음 생성될때 실행
            Debug.Log("플레이어 데이터가 준비됐습니다.");
        }

        private void OnEnable()
        {
            //오브젝트 활성화
            Debug.Log("플레이어가 로그인 했습니다.");
        }

        private void Start()
        {
            Debug.Log("사냥할 준비가 됐습니다.");
        }
        //--------------------------------------------
        //        이 윗 부분이 초기화 하는 부분이라고 생각하면 된다
        //--------------------------------------------

        private void FixedUpdate()
        {
            //이부분은 계속 고정적을 CPU를 많이 사용한다
            // 물리 연산 하는 곳이다.
            Debug.Log("이동!");
        }

        private void Update()
        {
            //게임 로직 업데이트
            // 주기적으로 돌아가는 로직을 수행하는곳
            // 환경에 따라서 실행주기가 떨어질수 있다.
            Debug.Log("몬스터 사냥!!");
        }

        private void LateUpdate()
        {
            //모든 업데이트가 다 끝난후 마지막에 실행
            Debug.Log("경험치 획득");
        }

        private void OnDisable()
        {
            //오브젝트가 비활성화 됐을때
            Debug.Log("플레이어가 로그아웃 했습니다.");
        }

        private void OnDestroy()
        {
            //오브젝트가 삭제가 되기전에 실행
            Debug.Log("플레이어 데이터를 해제 했습니다..");
        }
    }
}