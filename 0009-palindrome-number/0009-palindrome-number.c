bool isPalindrome(int x) {
    if (x < 0 || (x % 10 == 0 && x != 0)) {
            return false;
        }

    int reversedHalf = 0;
    int original = x;

    while (x > reversedHalf) {
        reversedHalf = reversedHalf * 10 + x % 10;
        x /= 10;
    }

    return x == reversedHalf || x == reversedHalf / 10;
}