
class BulkSelection {
    name = "BulkSelection";

    constructor({ category, subCategory }) {
        this.categories = document.querySelectorAll(category)
        this.subCategories = document.querySelectorAll(subCategory)
    }

    init() {
        [...this.categories].forEach(category => {
            category.addEventListener("input", () => this.bulk(category))
        });

        [...this.subCategories].forEach(sub => {
            sub.addEventListener("input", () => this.checkMainCategory(sub))
        })
    }

    bulk(category) {
        const target = category.dataset.target.toLowerCase()
        const relatedCategories = this.get(this.subCategories, "related", target)

        relatedCategories.forEach(c => {
            if (category.checked) {
                c.checked = true
            } else {
                c.checked = false
            }
        })
    }

    checkMainCategory(sub) {
        const related = sub.dataset.related.toLowerCase()

        const relatedCategories = this.get(this.subCategories, "related", related)
        const target = this.get(this.categories, "target", related)
        const checkedCategories = relatedCategories.filter(c => c.checked === true);

        target.forEach(t => {
            console.log('worked')
            if (checkedCategories.length !== relatedCategories.length) {
                t.checked = false
            } else {
                t.checked = true
            }
        })
    }

    get(main, attr, target) {
        const related = [...main].filter(c => c.dataset[attr].toLowerCase() === target)

        return related
    }
}


const selectCategories = new BulkSelection({
    category: ".category",
    subCategory: ".subcategory"
}).init()