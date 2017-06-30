#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.GameObject
struct GameObject_t1756533147;
// UiController
struct UiController_t2269452590;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GameManager
struct  GameManager_t2252321495  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject GameManager::pickUpPrefab
	GameObject_t1756533147 * ___pickUpPrefab_2;
	// UiController GameManager::uiController
	UiController_t2269452590 * ___uiController_3;
	// System.Int32 GameManager::maxCube
	int32_t ___maxCube_4;
	// System.Int32 GameManager::count
	int32_t ___count_5;
	// System.Single GameManager::timeLap
	float ___timeLap_6;
	// System.Boolean GameManager::isGameStart
	bool ___isGameStart_7;
	// System.Boolean GameManager::isGameOver
	bool ___isGameOver_8;

public:
	inline static int32_t get_offset_of_pickUpPrefab_2() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___pickUpPrefab_2)); }
	inline GameObject_t1756533147 * get_pickUpPrefab_2() const { return ___pickUpPrefab_2; }
	inline GameObject_t1756533147 ** get_address_of_pickUpPrefab_2() { return &___pickUpPrefab_2; }
	inline void set_pickUpPrefab_2(GameObject_t1756533147 * value)
	{
		___pickUpPrefab_2 = value;
		Il2CppCodeGenWriteBarrier(&___pickUpPrefab_2, value);
	}

	inline static int32_t get_offset_of_uiController_3() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___uiController_3)); }
	inline UiController_t2269452590 * get_uiController_3() const { return ___uiController_3; }
	inline UiController_t2269452590 ** get_address_of_uiController_3() { return &___uiController_3; }
	inline void set_uiController_3(UiController_t2269452590 * value)
	{
		___uiController_3 = value;
		Il2CppCodeGenWriteBarrier(&___uiController_3, value);
	}

	inline static int32_t get_offset_of_maxCube_4() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___maxCube_4)); }
	inline int32_t get_maxCube_4() const { return ___maxCube_4; }
	inline int32_t* get_address_of_maxCube_4() { return &___maxCube_4; }
	inline void set_maxCube_4(int32_t value)
	{
		___maxCube_4 = value;
	}

	inline static int32_t get_offset_of_count_5() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___count_5)); }
	inline int32_t get_count_5() const { return ___count_5; }
	inline int32_t* get_address_of_count_5() { return &___count_5; }
	inline void set_count_5(int32_t value)
	{
		___count_5 = value;
	}

	inline static int32_t get_offset_of_timeLap_6() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___timeLap_6)); }
	inline float get_timeLap_6() const { return ___timeLap_6; }
	inline float* get_address_of_timeLap_6() { return &___timeLap_6; }
	inline void set_timeLap_6(float value)
	{
		___timeLap_6 = value;
	}

	inline static int32_t get_offset_of_isGameStart_7() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___isGameStart_7)); }
	inline bool get_isGameStart_7() const { return ___isGameStart_7; }
	inline bool* get_address_of_isGameStart_7() { return &___isGameStart_7; }
	inline void set_isGameStart_7(bool value)
	{
		___isGameStart_7 = value;
	}

	inline static int32_t get_offset_of_isGameOver_8() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___isGameOver_8)); }
	inline bool get_isGameOver_8() const { return ___isGameOver_8; }
	inline bool* get_address_of_isGameOver_8() { return &___isGameOver_8; }
	inline void set_isGameOver_8(bool value)
	{
		___isGameOver_8 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
