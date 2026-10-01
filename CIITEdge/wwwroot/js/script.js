document.addEventListener("DOMContentLoaded", () => {
    const themeToggleBtn = document.getElementById("theme-toggle");
    const themeIcon = themeToggleBtn.querySelector("i");
    
    // Check user's preferred saved theme on system load
    const savedTheme = localStorage.getItem("theme");
    
    if (savedTheme === "light") {
        document.body.classList.add("light-theme");
        themeIcon.className = "fa-solid fa-sun"; // Switch icon to sun
    } else {
        document.body.classList.remove("light-theme");
        themeIcon.className = "fa-solid fa-moon"; // Retain moon icon
    }

    // Click handler engine
    themeToggleBtn.addEventListener("click", () => {
        document.body.classList.toggle("light-theme");
        
        // Update storage values and layout configurations dynamically
        if (document.body.classList.contains("light-theme")) {
            localStorage.setItem("theme", "light");
            themeIcon.className = "fa-solid fa-sun";
        } else {
            localStorage.setItem("theme", "dark");
            themeIcon.className = "fa-solid fa-moon";
        }
    });
});
document.addEventListener("DOMContentLoaded", () => {
    const joinBtn = document.getElementById("join-btn");
    const authModal = document.getElementById("auth-modal");
    const closeModal = document.getElementById("close-modal");

    // Modal Display Trigger
    if (joinBtn && authModal) {
        joinBtn.addEventListener("click", (e) => {
            e.preventDefault();
            authModal.classList.add("active");
            document.body.style.overflow = "hidden"; // Retain window scroll lock
        });
    }

    // Modal Close Action
    if (closeModal && authModal) {
        closeModal.addEventListener("click", () => {
            authModal.classList.remove("active");
            document.body.style.overflow = ""; // Reactivate core view scroll
        });

        // Close on clicking outside container box area
        authModal.addEventListener("click", (e) => {
            if (e.target === authModal) {
                authModal.classList.remove("active");
                document.body.style.overflow = "";
            }
        });
    }
});
// Accordion Collapsible Matrix Logic Engine
document.addEventListener("DOMContentLoaded", () => {
    const courseCards = document.querySelectorAll(".course-card");

    courseCards.forEach(card => {
        const toggleButton = card.querySelector(".btn-accordion-toggle");
        const panel = card.querySelector(".course-accordion-panel");

        if (toggleButton && panel) {
            toggleButton.addEventListener("click", (e) => {
                e.preventDefault();
                
                const isExpanded = card.classList.contains("panel-expanded");

                // Optional: Collapse all alternate open cards first (Single Accordion Behavior)
                courseCards.forEach(otherCard => {
                    if (otherCard !== card && otherCard.classList.contains("panel-expanded")) {
                        otherCard.classList.remove("panel-expanded");
                        otherCard.querySelector(".course-accordion-panel").style.maxHeight = null;
                    }
                });

                // Toggle targeted card performance metrics
                if (!isExpanded) {
                    card.classList.add("panel-expanded");
                    // Systematically calculates precise internal layout size parameters
                    panel.style.maxHeight = panel.scrollHeight + "px";
                } else {
                    card.classList.remove("panel-expanded");
                    panel.style.maxHeight = null;
                }
            });
        }
    });
});
// --- Client-Side Filtration Engine Logic ---
document.addEventListener("DOMContentLoaded", () => {
    const searchInput = document.getElementById("course-search-input");
    const tagButtons = document.querySelectorAll(".tag-btn");
    const courseCards = document.querySelectorAll(".course-card");
    const courseGrid = document.querySelector(".course-grid");

    // Create an inline placeholder reference error layer element
    const noResultsFallback = document.createElement("div");
    noResultsFallback.className = "no-results-banner card-hidden";
    noResultsFallback.innerHTML = `
        <i class="fa-solid fa-cloud-moon-rain"></i>
        <h3>No specialized IT tracks matched your criteria</h3>
        <p>Try refining your search keyword strings or resetting your category tracking tags.</p>
    `;
    if (courseGrid) courseGrid.appendChild(noResultsFallback);

    let activeFilterTag = "all";
    let activeSearchString = "";

    // Execution Core: Evaluates card tracking queries across parameters
    function executeCourseMatchingPipeline() {
        let visibleCount = 0;

        courseCards.forEach(card => {
            // Pick context metadata attributes nested deep within structural nodes
            const tagContainer = card.querySelector(".course-tag");
            const headingContainer = card.querySelector("h3");
            const summaryContainer = card.querySelector(".course-body p");

            const normalizedTag = tagContainer ? tagContainer.textContent.toLowerCase().trim() : "";
            const normalizedTitle = headingContainer ? headingContainer.textContent.toLowerCase() : "";
            const normalizedDesc = summaryContainer ? summaryContainer.textContent.toLowerCase() : "";

            // Evaluate Matrix 1: Does card tag match active selection cluster?
            const tagMatches = (activeFilterTag === "all" || normalizedTag === activeFilterTag);

            // Evaluate Matrix 2: Does title or description contain user query strings?
            const queryMatches = (
                normalizedTitle.includes(activeSearchString) || 
                normalizedDesc.includes(activeSearchString)
            );

            // Compute conditional truth flags 
            if (tagMatches && queryMatches) {
                card.classList.remove("card-hidden");
                visibleCount++;
            } else {
                card.classList.add("card-hidden");
                // Safety clear: Collapse if the card was left expanded while hiding
                card.classList.remove("panel-expanded");
                const openPanel = card.querySelector(".course-accordion-panel");
                if (openPanel) openPanel.style.maxHeight = null;
            }
        });

        // Toggle visibility over structural placeholder elements based on match depth
        if (visibleCount === 0) {
            noResultsFallback.classList.remove("card-hidden");
        } else {
            noResultsFallback.classList.add("card-hidden");
        }
    }

    // --- Interaction Hook 1: Text Entry Evaluation ---
    if (searchInput) {
        searchInput.addEventListener("input", (e) => {
            activeSearchString = e.target.value.toLowerCase().trim();
            executeCourseMatchingPipeline();
        });
    }

    // --- Interaction Hook 2: Tag Filter Selection Evaluation ---
    tagButtons.forEach(button => {
        button.addEventListener("click", () => {
            // Swap functional execution classes out across siblings
            tagButtons.forEach(btn => btn.classList.remove("active"));
            button.classList.add("active");

            activeFilterTag = button.getAttribute("data-filter").toLowerCase().trim();
            executeCourseMatchingPipeline();
        });
    });
});
// --- Interactive E-Commerce Checkout Engine ---
document.addEventListener("DOMContentLoaded", () => {
    const checkoutDrawer = document.getElementById("checkout-drawer");
    const closeDrawerBtn = document.getElementById("close-drawer");
    const checkoutTriggers = document.querySelectorAll(".btn-enroll-block");
    const procureBtn = document.getElementById("procure-access-btn");

    // Interface Manifest Selectors
    const chkTag = document.getElementById("chk-tag");
    const chkTitle = document.getElementById("chk-title");
    const chkDuration = document.getElementById("chk-duration");
    const chkPrice = document.getElementById("chk-price");
    const ledgerSubtotal = document.getElementById("ledger-subtotal");
    const ledgerTotal = document.getElementById("ledger-total");

    // Open Drawer & Map Parameters
    checkoutTriggers.forEach(button => {
        button.addEventListener("click", (e) => {
            e.preventDefault();

            // Travel upward structural tree nodes to pick parameter variables
            const targetCardInstance = button.closest(".course-card");

            const originTag = targetCardInstance.querySelector(".course-tag").innerText;
            const originTitle = targetCardInstance.querySelector("h3").innerText;
            const originDuration = targetCardInstance.querySelector(".course-meta span:first-child").innerText;
            const originPrice = targetCardInstance.querySelector(".price").innerText;

            // Map variables down into checkout panel nodes
            chkTag.innerText = originTag;
            chkTitle.innerText = originTitle;
            chkDuration.innerText = originDuration;
            chkPrice.innerText = originPrice;
            ledgerSubtotal.innerText = originPrice;
            ledgerTotal.innerText = originPrice;

            // Display Drawer Canvas Overrides
            if (checkoutDrawer) {
                checkoutDrawer.classList.add("drawer-active");
                document.body.style.overflow = "hidden"; // Freeze base document tracking bounds
            }
        });
    });

    // Close Actions Drawer Setup
    if (closeDrawerBtn && checkoutDrawer) {
        closeDrawerBtn.addEventListener("click", () => {
            checkoutDrawer.classList.remove("drawer-active");
            document.body.style.overflow = "";
        });

        // Close on clicking outside container box boundaries
        checkoutDrawer.addEventListener("click", (e) => {
            if (e.target === checkoutDrawer) {
                checkoutDrawer.classList.remove("drawer-active");
                document.body.style.overflow = "";
            }
        });
    }

    // Secure Purchase Handler Simulation Engine
    if (procureBtn) {
        procureBtn.addEventListener("click", () => {
            // Check session credentials persistence track
            const activeSessionToken = localStorage.getItem("userSession");

            if (!activeSessionToken) {
                alert("🔐 Access Denied: Please initialize your user account parameters via 'Join for Free' tracking actions before processing tuition layers.");
                // Gracefully collapse checkout drawer layout vectors to present auth options
                checkoutDrawer.classList.remove("drawer-active");
                document.body.style.overflow = "";
                return;
            }

            alert("🚀 System Confirmed: Cloud sandboxes provisioned. Welcome to the track!");
            checkoutDrawer.classList.remove("drawer-active");
            document.body.style.overflow = "";
        });
    }
});
