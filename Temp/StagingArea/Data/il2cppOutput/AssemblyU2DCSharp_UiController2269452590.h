#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.UI.Text
struct Text_t356221433;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// UnityEngine.UI.Text[]
struct TextU5BU5D_t4216439300;
// GameManager
struct GameManager_t2252321495;
// RankingController
struct RankingController_t4067507514;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UiController
struct  UiController_t2269452590  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Text UiController::timerText
	Text_t356221433 * ___timerText_2;
	// UnityEngine.UI.Text UiController::countText
	Text_t356221433 * ___countText_3;
	// UnityEngine.UI.Text UiController::instruction
	Text_t356221433 * ___instruction_4;
	// UnityEngine.GameObject UiController::nameField
	GameObject_t1756533147 * ___nameField_5;
	// UnityEngine.UI.Text[] UiController::rankText
	TextU5BU5D_t4216439300* ___rankText_6;
	// GameManager UiController::gameManager
	GameManager_t2252321495 * ___gameManager_7;
	// RankingController UiController::rankingController
	RankingController_t4067507514 * ___rankingController_8;

public:
	inline static int32_t get_offset_of_timerText_2() { return static_cast<int32_t>(offsetof(UiController_t2269452590, ___timerText_2)); }
	inline Text_t356221433 * get_timerText_2() const { return ___timerText_2; }
	inline Text_t356221433 ** get_address_of_timerText_2() { return &___timerText_2; }
	inline void set_timerText_2(Text_t356221433 * value)
	{
		___timerText_2 = value;
		Il2CppCodeGenWriteBarrier(&___timerText_2, value);
	}

	inline static int32_t get_offset_of_countText_3() { return static_cast<int32_t>(offsetof(UiController_t2269452590, ___countText_3)); }
	inline Text_t356221433 * get_countText_3() const { return ___countText_3; }
	inline Text_t356221433 ** get_address_of_countText_3() { return &___countText_3; }
	inline void set_countText_3(Text_t356221433 * value)
	{
		___countText_3 = value;
		Il2CppCodeGenWriteBarrier(&___countText_3, value);
	}

	inline static int32_t get_offset_of_instruction_4() { return static_cast<int32_t>(offsetof(UiController_t2269452590, ___instruction_4)); }
	inline Text_t356221433 * get_instruction_4() const { return ___instruction_4; }
	inline Text_t356221433 ** get_address_of_instruction_4() { return &___instruction_4; }
	inline void set_instruction_4(Text_t356221433 * value)
	{
		___instruction_4 = value;
		Il2CppCodeGenWriteBarrier(&___instruction_4, value);
	}

	inline static int32_t get_offset_of_nameField_5() { return static_cast<int32_t>(offsetof(UiController_t2269452590, ___nameField_5)); }
	inline GameObject_t1756533147 * get_nameField_5() const { return ___nameField_5; }
	inline GameObject_t1756533147 ** get_address_of_nameField_5() { return &___nameField_5; }
	inline void set_nameField_5(GameObject_t1756533147 * value)
	{
		___nameField_5 = value;
		Il2CppCodeGenWriteBarrier(&___nameField_5, value);
	}

	inline static int32_t get_offset_of_rankText_6() { return static_cast<int32_t>(offsetof(UiController_t2269452590, ___rankText_6)); }
	inline TextU5BU5D_t4216439300* get_rankText_6() const { return ___rankText_6; }
	inline TextU5BU5D_t4216439300** get_address_of_rankText_6() { return &___rankText_6; }
	inline void set_rankText_6(TextU5BU5D_t4216439300* value)
	{
		___rankText_6 = value;
		Il2CppCodeGenWriteBarrier(&___rankText_6, value);
	}

	inline static int32_t get_offset_of_gameManager_7() { return static_cast<int32_t>(offsetof(UiController_t2269452590, ___gameManager_7)); }
	inline GameManager_t2252321495 * get_gameManager_7() const { return ___gameManager_7; }
	inline GameManager_t2252321495 ** get_address_of_gameManager_7() { return &___gameManager_7; }
	inline void set_gameManager_7(GameManager_t2252321495 * value)
	{
		___gameManager_7 = value;
		Il2CppCodeGenWriteBarrier(&___gameManager_7, value);
	}

	inline static int32_t get_offset_of_rankingController_8() { return static_cast<int32_t>(offsetof(UiController_t2269452590, ___rankingController_8)); }
	inline RankingController_t4067507514 * get_rankingController_8() const { return ___rankingController_8; }
	inline RankingController_t4067507514 ** get_address_of_rankingController_8() { return &___rankingController_8; }
	inline void set_rankingController_8(RankingController_t4067507514 * value)
	{
		___rankingController_8 = value;
		Il2CppCodeGenWriteBarrier(&___rankingController_8, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
