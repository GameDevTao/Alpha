using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 有限状态机
/// </summary>
public class FiniteStateMachine
{
    private State m_CurrentState = null;

    /// <summary>
    /// 状态容器
    /// </summary>
    Dictionary<string, State> m_StateMap = new Dictionary<string, State>();

    /// <summary>
    /// 添加状态
    /// </summary>
    /// <param name="state"></param>
    public void AddState(State state)
    {
        if (m_StateMap.ContainsKey(state.StateName))
        {
            Logger.Error($"[FiniteStateMachine](AddState) State Repeated! {state.StateName}");
            return;
        }
        m_StateMap.Add(state.StateName, state);
    }

    IUpdatable IUpdatableState = null;
    /// <summary>
    /// 每帧更新方法
    /// </summary>
    public void OnUpdate()
    {
        if (null != IUpdatableState)
        {
            IUpdatableState.OnUpdate();
        }
    }

    /// <summary>
    /// 切换当前状态
    /// </summary>
    /// <param name="stateName"></param>
    public void ChangeState(string stateName)
    {
        State NextState;
        if (!m_StateMap.TryGetValue(stateName, out NextState))
        {
            Logger.Error($"[FiniteStateMachine](ChangeState) State Empty! {stateName}");
            return;
        }
        if (null != m_CurrentState)
        {
            m_CurrentState.OnExit();

            if (IUpdatableState == m_CurrentState)
            {
                IUpdatableState = null;
            }
        }
        NextState.OnEnter();

        m_CurrentState = NextState;

        if (m_CurrentState is IUpdatable)
        {
            IUpdatableState = (IUpdatable)m_CurrentState;
        }
    }
}
