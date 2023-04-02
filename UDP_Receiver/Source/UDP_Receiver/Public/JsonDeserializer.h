// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "Json.h"
#include "JsonUtilities.h"
#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"
#include "JsonDeserializer.generated.h"



USTRUCT(BlueprintType)
struct FParameters
{
	GENERATED_BODY()

public:
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	TArray<int32> intToReceive;
	
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	TArray<bool> boolToReceive;
	
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	TArray<FString> stringToReceive;
	
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	TArray<float> floatToReceive;
};


UCLASS()
class UDP_RECEIVER_API UJsonDeserializer : public UBlueprintFunctionLibrary
{
	GENERATED_BODY()

public:
	
	UFUNCTION(BlueprintCallable)
	static FParameters JsonDeserialize(FString jsonString);


	
};






