export function init(tbodySelector, dotnetRef) {
    const tbody = document.querySelector(tbodySelector);
    if (!tbody) return;

    let dragging = null;

    function onDragStart(e) {
        const tr = e.currentTarget;
        dragging = tr;
        e.dataTransfer.effectAllowed = 'move';
        e.dataTransfer.setData('text/plain', tr.dataset.id);
        tr.classList.add('dragging');
    }

    function onDragOver(e) {
        e.preventDefault();
        if (!dragging) return;
        const target = e.currentTarget;
        if (target === dragging) return;

        const rect = target.getBoundingClientRect();
        const before = (e.clientY - rect.top) < rect.height / 2;
        target.parentNode.insertBefore(dragging, before ? target : target.nextSibling);
    }

    function onDragEnd() {
        if (!dragging) return;
        dragging.classList.remove('dragging');
        dragging = null;

        const ids = Array.from(tbody.querySelectorAll('tr[data-id]')).map(tr => tr.dataset.id);
        dotnetRef.invokeMethodAsync('OnRowOrderChanged', ids);
    }

    const rows = Array.from(tbody.querySelectorAll('tr'));
    rows.forEach(tr => {
        tr.setAttribute('draggable', 'true');
        tr.addEventListener('dragstart', onDragStart);
        tr.addEventListener('dragover', onDragOver);
        tr.addEventListener('dragend', onDragEnd);
    });

    return {
        dispose() {
            rows.forEach(tr => {
                tr.removeEventListener('dragstart', onDragStart);
                tr.removeEventListener('dragover', onDragOver);
                tr.removeEventListener('dragend', onDragEnd);
            });
        }
    };
}
