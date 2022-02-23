using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums = {1,2,3,4,5,6};
		int z = 7;
		
        for(int i = 0; i < 6; i++){
			if(nums[i] < z){
				for(int j = i; j < 6; j++){
					if(nums[i] + nums[j] == z){
						Debug.Log(nums[i] + " " + nums[j]);
					}
				}
			}
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
