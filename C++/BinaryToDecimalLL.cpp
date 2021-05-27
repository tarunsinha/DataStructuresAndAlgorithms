
struct ListNode
{
    int val;
    ListNode *next;
    ListNode() : val(0), next(nullptr) {}
    ListNode(int x) : val(x), next(nullptr) {}
    ListNode(int x, ListNode *next) : val(x), next(next) {}
};

#include <bits/stdc++.h>
class Solution
{
public:
    int getDecimalValue(ListNode *head)
    {
        int res = 0;
        while (head != NULL)
        {
            res = (res << 1) + (head->val == 1 ? 1 : 0);
            head = head->next;
        }
        return res;
    }
};