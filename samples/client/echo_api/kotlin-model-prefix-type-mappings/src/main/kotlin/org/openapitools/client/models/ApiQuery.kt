/**
 *
 * Please note:
 * This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * Do not edit this file manually.
 *
 */

@file:Suppress(
    "ArrayInDataClass",
    "EnumEntryName",
    "RemoveRedundantQualifierName",
    "UnusedImport"
)

package org.openapitools.client.models


import com.google.gson.annotations.SerializedName

/**
 * 
 *
 * @param id Query
 * @param outcomes 
 */


data class ApiQuery (

    /* Query */
    @SerializedName("id")
    val id: kotlin.Long? = null,

    @SerializedName("outcomes")
    val outcomes: kotlin.collections.List<ApiQuery.Outcomes>? = null

) {

    /**
     * 
     *
     * Values: SUCCESS,FAILURE,SKIPPED
     */
    enum class Outcomes(val value: kotlin.String) {
        @SerializedName(value = "SUCCESS") SUCCESS("SUCCESS"),
        @SerializedName(value = "FAILURE") FAILURE("FAILURE"),
        @SerializedName(value = "SKIPPED") SKIPPED("SKIPPED");
    }

}

