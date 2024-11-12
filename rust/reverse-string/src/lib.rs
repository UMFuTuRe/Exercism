use unicode_segmentation::UnicodeSegmentation;

pub fn reverse(input: &str) -> String {
    let mut reverse_input = String::new();

    for letter in input.graphemes(true) {
        reverse_input.insert_str(0, letter);
    }

    reverse_input
}
