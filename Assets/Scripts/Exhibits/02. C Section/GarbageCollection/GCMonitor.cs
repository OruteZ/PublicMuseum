using UnityEngine;
using System;

public class GCMonitor : MonoBehaviour
{
    // 세대별 마지막 수집 카운트 저장
    [SerializeField]
    private int[] lastCounts = new int[GC.MaxGeneration + 1];

    public static event Action<int> OnGC;  // 세대 번호를 인수로 받는 이벤트

    void Start()
    {
        for (int gen = 0; gen <= GC.MaxGeneration; gen++)
            lastCounts[gen] = GC.CollectionCount(gen);
    }

    void Update()
    {
        for (int gen = 0; gen <= GC.MaxGeneration; gen++)
        {
            int count = GC.CollectionCount(gen);
            if (count != lastCounts[gen])
            {
                // 세대 gen에서 GC가 일어났음을 감지
                OnGC?.Invoke(gen);
                lastCounts[gen] = count;
            }
        }
    }
}
