#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.Material
struct Material_t193706927;
// GameManager
struct GameManager_t2252321495;
// UiController
struct UiController_t2269452590;
// UnityEngine.Rigidbody
struct Rigidbody_t4233889191;
// UnityEngine.Renderer
struct Renderer_t257310565;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PlayerController
struct  PlayerController_t4148409433  : public MonoBehaviour_t1158329972
{
public:
	// System.Single PlayerController::speed
	float ___speed_2;
	// UnityEngine.Material PlayerController::pickUpYellow
	Material_t193706927 * ___pickUpYellow_3;
	// UnityEngine.Material PlayerController::pickUpPurple
	Material_t193706927 * ___pickUpPurple_4;
	// GameManager PlayerController::gameManager
	GameManager_t2252321495 * ___gameManager_5;
	// UiController PlayerController::uiController
	UiController_t2269452590 * ___uiController_6;
	// UnityEngine.Rigidbody PlayerController::rb
	Rigidbody_t4233889191 * ___rb_7;
	// UnityEngine.Renderer PlayerController::rend
	Renderer_t257310565 * ___rend_8;

public:
	inline static int32_t get_offset_of_speed_2() { return static_cast<int32_t>(offsetof(PlayerController_t4148409433, ___speed_2)); }
	inline float get_speed_2() const { return ___speed_2; }
	inline float* get_address_of_speed_2() { return &___speed_2; }
	inline void set_speed_2(float value)
	{
		___speed_2 = value;
	}

	inline static int32_t get_offset_of_pickUpYellow_3() { return static_cast<int32_t>(offsetof(PlayerController_t4148409433, ___pickUpYellow_3)); }
	inline Material_t193706927 * get_pickUpYellow_3() const { return ___pickUpYellow_3; }
	inline Material_t193706927 ** get_address_of_pickUpYellow_3() { return &___pickUpYellow_3; }
	inline void set_pickUpYellow_3(Material_t193706927 * value)
	{
		___pickUpYellow_3 = value;
		Il2CppCodeGenWriteBarrier(&___pickUpYellow_3, value);
	}

	inline static int32_t get_offset_of_pickUpPurple_4() { return static_cast<int32_t>(offsetof(PlayerController_t4148409433, ___pickUpPurple_4)); }
	inline Material_t193706927 * get_pickUpPurple_4() const { return ___pickUpPurple_4; }
	inline Material_t193706927 ** get_address_of_pickUpPurple_4() { return &___pickUpPurple_4; }
	inline void set_pickUpPurple_4(Material_t193706927 * value)
	{
		___pickUpPurple_4 = value;
		Il2CppCodeGenWriteBarrier(&___pickUpPurple_4, value);
	}

	inline static int32_t get_offset_of_gameManager_5() { return static_cast<int32_t>(offsetof(PlayerController_t4148409433, ___gameManager_5)); }
	inline GameManager_t2252321495 * get_gameManager_5() const { return ___gameManager_5; }
	inline GameManager_t2252321495 ** get_address_of_gameManager_5() { return &___gameManager_5; }
	inline void set_gameManager_5(GameManager_t2252321495 * value)
	{
		___gameManager_5 = value;
		Il2CppCodeGenWriteBarrier(&___gameManager_5, value);
	}

	inline static int32_t get_offset_of_uiController_6() { return static_cast<int32_t>(offsetof(PlayerController_t4148409433, ___uiController_6)); }
	inline UiController_t2269452590 * get_uiController_6() const { return ___uiController_6; }
	inline UiController_t2269452590 ** get_address_of_uiController_6() { return &___uiController_6; }
	inline void set_uiController_6(UiController_t2269452590 * value)
	{
		___uiController_6 = value;
		Il2CppCodeGenWriteBarrier(&___uiController_6, value);
	}

	inline static int32_t get_offset_of_rb_7() { return static_cast<int32_t>(offsetof(PlayerController_t4148409433, ___rb_7)); }
	inline Rigidbody_t4233889191 * get_rb_7() const { return ___rb_7; }
	inline Rigidbody_t4233889191 ** get_address_of_rb_7() { return &___rb_7; }
	inline void set_rb_7(Rigidbody_t4233889191 * value)
	{
		___rb_7 = value;
		Il2CppCodeGenWriteBarrier(&___rb_7, value);
	}

	inline static int32_t get_offset_of_rend_8() { return static_cast<int32_t>(offsetof(PlayerController_t4148409433, ___rend_8)); }
	inline Renderer_t257310565 * get_rend_8() const { return ___rend_8; }
	inline Renderer_t257310565 ** get_address_of_rend_8() { return &___rend_8; }
	inline void set_rend_8(Renderer_t257310565 * value)
	{
		___rend_8 = value;
		Il2CppCodeGenWriteBarrier(&___rend_8, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
