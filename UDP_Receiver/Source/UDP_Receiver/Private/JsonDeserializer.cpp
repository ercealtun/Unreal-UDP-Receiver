// Fill out your copyright notice in the Description page of Project Settings.


#include "JsonDeserializer.h"

UPROPERTY(BlueprintCallable)
FParameters UJsonDeserializer::JsonDeserialize(FString jsonString)
{
	FParameters Parameters;
	TSharedPtr<FJsonObject> JsonObject;
	TSharedRef<TJsonReader<TCHAR>> JsonReader = TJsonReaderFactory<TCHAR>::Create(jsonString);

	if (FJsonSerializer::Deserialize(JsonReader, JsonObject))
	{
		UE_LOG(LogTemp, Warning, TEXT("JSON string successfully deserialized"))

		if(JsonObject.IsValid())
		{
			
			// Receiving string
			TArray<TSharedPtr<FJsonValue>> stringJsonArray = JsonObject->GetArrayField("stringToSend");
			for(TSharedPtr<FJsonValue> stringJson : stringJsonArray)
			{
				Parameters.stringToReceive.Add(stringJson->AsString());
			}

			// Receiving boolean
			TArray<TSharedPtr<FJsonValue>> boolJsonArray = JsonObject->GetArrayField("boolToSend");
			for(TSharedPtr<FJsonValue> boolJson : boolJsonArray)
			{
				Parameters.boolToReceive.Add(boolJson->AsBool());
			}

			// Receiving integer
			TArray<TSharedPtr<FJsonValue>> intJsonArray = JsonObject->GetArrayField("intToSend");
			for(TSharedPtr<FJsonValue> intJson : intJsonArray)
			{
				Parameters.intToReceive.Add(intJson->AsNumber());
			}

			// Receiving float
			TArray<TSharedPtr<FJsonValue>> floatJsonArray = JsonObject->GetArrayField("floatToSend");
			for(TSharedPtr<FJsonValue> floatJson : floatJsonArray)
			{
				Parameters.floatToReceive.Add(floatJson->AsNumber());
			}

			UE_LOG(LogTemp, Warning, TEXT("JSON object is created successfully"))
			
			
		}
		
		
	}
	else
	{
		UE_LOG(LogTemp, Warning, TEXT("JSON string deserialize failed"))
	}

	return Parameters;
	
	
}

