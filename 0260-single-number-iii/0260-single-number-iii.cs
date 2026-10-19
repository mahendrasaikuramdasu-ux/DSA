public class Solution {

    int find_first_set_bit(int num){
        int bit = 1;
        int cnt = 0;
        for(int i=1; i<=32; i++){
            int set = bit & num;
            if(set != 0){
                break;
            }
            cnt+=1;
            bit = bit << 1;
        }
        return cnt;
    }

    int find_element(int[] nums, int cnt, int n, bool pos){
        int xor = 0;
        int bit = 1 << cnt;
        for(int i=0; i<n; i++){
            if(pos && nums[i] >= 0 && (nums[i] & bit) != 0){
                xor = nums[i] ^ xor;
            }
            if(!pos && nums[i] < 0){
                int curr = -nums[i];
                if((curr & bit) != 0){
                    xor = curr ^ xor;
                }
            }
        }
        return xor;
    }

    public int[] SingleNumber(int[] nums) {
        int n = nums.Length;
        int xor = 0;
        int m_xor = 0;
        int zeros = 0;
        for(int i=0; i<n; i++){
            if(nums[i] >= 0){
                xor = xor ^ nums[i];
            }
            else{
                m_xor = (m_xor ^ (-nums[i]));
            }
            if(nums[i] == 0){
                zeros+=1;
            }
        }
        if(zeros == 0 && xor != 0 && m_xor != 0){
            return new int[] {xor, -m_xor};
        }
        if(zeros == 1 && m_xor != 0){
            return new int[] {0, -m_xor};
        }
        else if(xor != 0){
            int ans = find_first_set_bit(xor);
            int ele_p = find_element(nums, ans, n, true);
            int ele_p2 = xor ^ ele_p;
            return new int[] {ele_p, ele_p2};
        }
        int cnt = find_first_set_bit(m_xor);
        int ele = find_element(nums, cnt, n, false);
        int ele_2 = m_xor ^ ele;
        return new int[] {-ele, -ele_2};
    }
}