public class Solution {
    public int MinOperations(int[] nums, int x) {
        
        int target = nums.Sum() - x;
        int n = nums.Length;
        if(target < 0) return -1;
        if(nums.Sum() == x) return n;
        int left=0, n_target = -1, cur_sum =0;
        for(int i=0; i< n;i++){
            if(cur_sum < target){
                cur_sum += nums[i];
            }
            while(cur_sum>= target){
                if(cur_sum == target){
                    n_target = Math.Max(n_target, i-left+1);
                }
                cur_sum -= nums[left];
                left++;
            }
        }
    if(n_target != -1){
        return n- n_target;
    }else{return -1;}
    }
    
}
